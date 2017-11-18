"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var platform_browser_1 = require("@angular/platform-browser");
var router_1 = require("@angular/router");
var app_component_1 = require("./app.component");
var http_1 = require("@angular/common/http");
var table_shops_component_1 = require("./Components/table-shops/table-shops.component");
var table_goods_component_1 = require("./Components/table-goods/table-goods.component");
var shop_service_1 = require("./Components/table-shops/shop.service");
var goods_service_1 = require("./Components/table-goods/goods.service");
var appRoutes = [
    { path: '', redirectTo: 'shops', pathMatch: 'full' },
    { path: 'shops', component: table_shops_component_1.TableShopsComponent },
    { path: 'shops/:id/goods', component: table_goods_component_1.TableGoodsComponent },
    { path: '**', redirectTo: 'shops' }
];
var AppModule = (function () {
    function AppModule() {
    }
    return AppModule;
}());
AppModule = __decorate([
    core_1.NgModule({
        imports: [platform_browser_1.BrowserModule, http_1.HttpClientModule, router_1.RouterModule.forRoot(appRoutes, { enableTracing: true })],
        declarations: [app_component_1.AppComponent, table_shops_component_1.TableShopsComponent, table_goods_component_1.TableGoodsComponent],
        providers: [shop_service_1.ShopService, goods_service_1.GoodsService],
        bootstrap: [app_component_1.AppComponent]
    })
], AppModule);
exports.AppModule = AppModule;
//# sourceMappingURL=app.module.js.map