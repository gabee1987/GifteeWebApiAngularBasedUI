import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/add/operator/map'

@Injectable()
export class GifteeFormService {

    constructor(private http: Http) { }

    getUsers() {
        return this.http.get('/api/users')
            .map(res => res.json());
    }

    //addGiftees() {
    //    return this.http.post('/api/giftees', )
    //        .map(res => res.json());
    //}
}