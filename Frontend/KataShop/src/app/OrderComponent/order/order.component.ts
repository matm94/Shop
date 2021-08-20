import { ApiDataService } from './../../Shared/api-data.service';
import { Order } from './../../Models/Order';
import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpClientModule } from '@angular/common/http';

@Component({
  selector: 'app-order',
  templateUrl: './order.component.html',
  styleUrls: ['./order.component.css']
})
export class OrderComponent implements OnInit {

  orderData;
  allOrderData;
  constructor(public dataFromAPi: ApiDataService)
  {
    this.GetDataFromApi();
    this.GetAllOrderDataFromAPI();
   }

  ngOnInit(): void {
  }

  GetDataFromApi(): void
  {

    this.dataFromAPi.GetOrderByLastNameDataFromApi().subscribe(
      data =>
      {
        this.orderData = data;
        console.log(this.orderData);
      }, (err) =>
      {
        console.log(' Cannot get data from URL ' + err);
      }
    );
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
}
