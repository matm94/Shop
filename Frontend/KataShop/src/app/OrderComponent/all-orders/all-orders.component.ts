import { CompleteOrder } from './../../Models/CompleteOrder';
import { APIOrderPageResult } from './../../Models/APIOrderPageResult';
import { Component, OnInit } from '@angular/core';
import { ApiDataService } from 'src/app/Shared/api-data.service';

@Component({
  selector: 'app-all-orders',
  templateUrl: './all-orders.component.html',
  styleUrls: ['./all-orders.component.css']
})
export class AllOrdersComponent implements OnInit {

  allOrderData: APIOrderPageResult;
  completeOrderData: CompleteOrder[];

  constructor(public dataFromAPi: ApiDataService) { }

  ngOnInit(): void {
    this.GetAllOrderDataFromAPI();
  }

  GetAllOrderDataFromAPI(): void
  {
    this.dataFromAPi.GetAllOrdersDataFromApi().subscribe(
      data =>
      {
        this.allOrderData = data;
        console.log(this.allOrderData);
      }, (err) =>
      {
        console.log('cannot get data form URL ' + err);
      }
    );
  }

  /*MapApiDataToCompleteOrder(data: APIOrderPageResult): CompleteOrder[]
  {
    const completeOrderList: Array<CompleteOrder> = [];
    data.items.forEach(item =>
      {
        const order = new CompleteOrder();
        order.firstName = item.firstName;
        order.lastName = item.lastName;
        order.phoneNumber = item.phoneNumber;
        order.email = item.email;
        order.productPrice = item.productPrice;
        order.orderStatus = item.orderStatus;
        order.shipmentPrice = item.shipmentPrice;
        order.shipmentStatus = item.shipmentStatus;
        completeOrderList.push(order);
      });
    console.log(completeOrderList);
    return completeOrderList;
  }
*/
}
