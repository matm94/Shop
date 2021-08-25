import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ApiDataService } from 'src/app/Shared/api-data.service';

@Component({
  selector: 'app-view-order',
  templateUrl: './view-order.component.html',
  styleUrls: ['./view-order.component.css']
})
export class ViewOrderComponent implements OnInit {
  oderId;
  viewDataFromApi;
  constructor(public dataFromAPi: ApiDataService, public activatedRoute: ActivatedRoute) { }

  ngOnInit(): void {

    this.GetIdFromActivatedRoute();
    this.GetViewDataFromAPIById();
  }

  GetIdFromActivatedRoute(): void
  {
    this.activatedRoute.params.subscribe( data =>
      {
        this.oderId = data.id;
        console.log('Order Id ActivatedRoute' + this.oderId);
      }
    );
  }

  GetViewDataFromAPIById(): void
  {
    this.dataFromAPi.GetOrderByIdDataFromApi(this.oderId).subscribe(data =>
      {
        this.viewDataFromApi = data;
        console.log(this.viewDataFromApi);
      }, (err) =>
      {
        console.log('cannot get data from URL' + err);
      }
      );
  }



}
