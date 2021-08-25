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

  lastNameData;
  idData;
  allOrderData;
  completeOrderData;
  lastName = 'Rivia';
  id = 'efc75b31-97e9-4f0b-71fc-08d9420e8f46';
  constructor(public dataFromAPi: ApiDataService)
  {
    this.GetDataByLastNameFromApi();
    this.GetOrderByIdFromAPI();
    this.GetCompleteOrderDataFromAPI();
     }

  ngOnInit(): void {
  }

  GetDataByLastNameFromApi(): void
  {

    this.dataFromAPi.GetOrderByLastNameDataFromApi(this.lastName).subscribe(
      data =>
      {
        this.lastNameData = data;
        console.log('ByLastName' + this.lastNameData);
      }, (err) =>
      {
        console.log(' Cannot get data from URL ' + err);
      }
    );
  }
  GetOrderByIdFromAPI(): void
  {
    this.dataFromAPi.GetOrderByIdDataFromApi(this.id).subscribe(
      data =>
      {
        this.idData = data;
        console.log('Byid: ' + this.idData);
      }, (err) =>
      {
        console.log(' Cannot get data from URL ' + err);
      }
    );
  }


  GetCompleteOrderDataFromAPI(): void
  {
    this.dataFromAPi.GetCompleteOrderById(this.id).subscribe(
      data =>
      {
        this.completeOrderData = data;
        console.log('CompleteData ' + this.completeOrderData);
      }, (err) =>
      {
        console.log('cannot get data form URL ' + err);
      }
    );
  }
}
