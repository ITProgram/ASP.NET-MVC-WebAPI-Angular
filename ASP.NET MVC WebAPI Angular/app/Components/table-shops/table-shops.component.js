"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var http_1 = require("@angular/common/http");
var shop_service_1 = require("./shop.service");
var TableShopsComponent = (function () {
    function TableShopsComponent(http, shopService) {
        this.http = http;
        this.shopService = shopService;
    }
    TableShopsComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.shopService.getShops().subscribe(function (shops) { _this.shops = shops; });
    };
    return TableShopsComponent;
}());
TableShopsComponent = __decorate([
    core_1.Component({
        selector: 'table-shops',
        templateUrl: './table-shops.component.html'
    }),
    __metadata("design:paramtypes", [http_1.HttpClient,
        shop_service_1.ShopService])
], TableShopsComponent);
exports.TableShopsComponent = TableShopsComponent;
//# sourceMappingURL=table-shops.component.js.map