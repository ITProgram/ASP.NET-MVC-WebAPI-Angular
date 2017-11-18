import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ShopService } from './shop.service';
import { Shop } from './shop.model';
@Component({
    selector: 'table-shops',
    templateUrl: './table-shops.component.html'
})
export class TableShopsComponent implements OnInit {
    shops: Shop[];
    constructor(
        private http: HttpClient,
        private shopService: ShopService) { }
    ngOnInit() {
        this.shopService.getShops().subscribe(shops => { this.shops = shops; });

    }
}
