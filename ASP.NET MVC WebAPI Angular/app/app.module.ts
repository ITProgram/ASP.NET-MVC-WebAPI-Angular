import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';


import { Routes, RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';

import { TableShopsComponent } from './Components/table-shops/table-shops.component';
import { TableGoodsComponent } from './Components/table-goods/table-goods.component';

import { ShopService } from './Components/table-shops/shop.service';
import { GoodsService } from './Components/table-goods/goods.service';

const appRoutes: Routes = [

    { path: '', redirectTo: 'shops', pathMatch: 'full' },
    { path: 'shops', component: TableShopsComponent },
    { path: 'shops/:id/goods', component: TableGoodsComponent },
    { path: '**', redirectTo: 'shops' }
    
];

@NgModule({
    imports: [BrowserModule, HttpClientModule, RouterModule.forRoot(appRoutes, { enableTracing:true })],
    declarations: [AppComponent, TableShopsComponent, TableGoodsComponent],
    providers: [ShopService, GoodsService],
    bootstrap: [AppComponent]
})

export class AppModule { }
