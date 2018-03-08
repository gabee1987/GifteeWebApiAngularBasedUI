import { Component, OnInit } from '@angular/core';

import { GifteeFormService } from '../../services/giftee-form.service';
import { UserListService } from '../../services/userList.service';
import { ToastyService, ToastyConfig, ToastOptions, ToastData } from 'ng2-toasty';

@Component({
    selector: 'app-giftee-form',
    templateUrl: './giftee-form.component.html',
    styleUrls: ['./giftee-form.component.css']
})
export class GifteeFormComponent implements OnInit {

    //public toastOptions: ToastOptions;

    constructor(private gifteeFormService: GifteeFormService,
                private userListService: UserListService,
                private toastyService: ToastyService,
                private toastyConfig: ToastyConfig) { this.toastyConfig.theme = 'bootstrap'; }

    users: any[];
    user: any = {};
    giftees: any[];
    giftee: any = {};




    ngOnInit() {
        this.userListService.getUsers().subscribe(users =>
            this.users = users);
        console.log("USERS", this.users);
    }

    onUserChange() {
        console.log("GIFTEE", this.user.giftees);
        var selectedUser = this.users.find(u => u.id == this.user)
        this.giftees = selectedUser ? selectedUser.giftees : [];
        this.giftee.userId = selectedUser ? selectedUser.id : undefined;
    }

    submit() {
        this.gifteeFormService.createGiftee(this.giftee)
            .subscribe(x => console.log(x));
    }

    //initToast() {
    //    this.toastyConfig.theme = 'bootstrap';
    //    this.toastyConfig.position = "top-right";
    //    this.toastOptions = {
    //        title: "",
    //        msg: "",
    //        showClose: true,
    //        timeout: 5000,
    //        theme: "bootstrap",
    //        onAdd: (toast: ToastData) => {
    //            console.log('Toast ' + toast.id + ' has been added!');
    //        },
    //        onRemove: function (toast: ToastData) {
    //            console.log('Toast ' + toast.id + ' has been removed!');
    //        }
    //    };
    //}
}