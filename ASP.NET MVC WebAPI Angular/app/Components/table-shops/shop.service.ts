import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Shop } from './shop.model';

import { Observable } from 'rxjs/Observable';
import { of } from 'rxjs/observable/of';

@Injectable()
export class ShopService {

    constructor(private http: HttpClient) { }
    getShops(): Observable<Shop[]> {
        return this.http.get<Shop[]>('/api/shops/')
    }
}