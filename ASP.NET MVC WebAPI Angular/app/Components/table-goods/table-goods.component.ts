import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { ActivatedRoute } from '@angular/router';
import { GoodsService } from './goods.service';
import { Goods } from './goods.model';
@Component({
    selector: 'table-goods',
    templateUrl: './table-goods.component.html'
})
export class TableGoodsComponent implements OnInit {

    goods: Goods[];
    shopID: number;

    constructor(
        private activateRoute: ActivatedRoute,
        private http: HttpClient,
        private goodsService: GoodsService) {
        this.shopID = activateRoute.snapshot.params['id']
    }

    ngOnInit() {
        this.goodsService.getGoods(this.shopID).subscribe(goods => { this.goods = goods; });

    }
}
