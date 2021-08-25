import { Component, OnInit } from '@angular/core';
import { ApiDataService } from 'src/app/Shared/api-data.service';

@Component({
  selector: 'app-all-orders',
  templateUrl: './all-orders.component.html',
  styleUrls: ['./all-orders.component.css']
})
export class AllOrdersComponent implements OnInit {

  allOrderData;
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

}
