﻿import { Component, OnInit } from '@angular/core';

import { GifteeFormService } from '../../services/giftee-form.service';
import { UserListService } from '../../services/userList.service';

@Component({
    selector: 'app-giftee-form',
    templateUrl: './giftee-form.component.html',
    styleUrls: ['./giftee-form.component.css']
})
export class GifteeFormComponent implements OnInit {

    constructor(private gifteeFormService: GifteeFormService,
                private userListService: UserListService) { }

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
}