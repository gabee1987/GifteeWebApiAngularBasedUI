import { Component, OnInit } from '@angular/core';

@Component({
    selector: 'app-giftee-form',
    templateUrl: './giftee-form.component.html',
    styleUrls: ['./giftee-form.component.css']
})
export class GifteeFormComponent implements OnInit {

    //constructor(private gifteeFormService: GifteeFormService) { }

    users: any = [];
    giftees: any = [];
    giftee: any = {};




    ngOnInit() {
        //this.gifteeFormService.getUsers().subscribe(users =>
        //    this.users = users);
        //console.log("USERS", this.users);
    }
}