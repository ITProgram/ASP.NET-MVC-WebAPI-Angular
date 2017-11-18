import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Goods } from './goods.model';

import { Observable } from 'rxjs/Observable';
import { of } from 'rxjs/observable/of';

@Injectable()
export class GoodsService {

    constructor(private http: HttpClient) { }
    getGoods(id:number): Observable<Goods[]> {
        return this.http.get<Goods[]>(`/api/shops/${id}/goods`)
    }
}