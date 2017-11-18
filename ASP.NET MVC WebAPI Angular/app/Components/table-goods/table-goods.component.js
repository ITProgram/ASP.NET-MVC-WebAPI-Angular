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
var router_1 = require("@angular/router");
var goods_service_1 = require("./goods.service");
var TableGoodsComponent = (function () {
    function TableGoodsComponent(activateRoute, http, goodsService) {
        this.activateRoute = activateRoute;
        this.http = http;
        this.goodsService = goodsService;
        this.shopID = activateRoute.snapshot.params['id'];
    }
    TableGoodsComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.goodsService.getGoods(this.shopID).subscribe(function (goods) { _this.goods = goods; });
    };
    return TableGoodsComponent;
}());
TableGoodsComponent = __decorate([
    core_1.Component({
        selector: 'table-goods',
        templateUrl: './table-goods.component.html'
    }),
    __metadata("design:paramtypes", [router_1.ActivatedRoute,
        http_1.HttpClient,
        goods_service_1.GoodsService])
], TableGoodsComponent);
exports.TableGoodsComponent = TableGoodsComponent;
//# sourceMappingURL=table-goods.component.js.map