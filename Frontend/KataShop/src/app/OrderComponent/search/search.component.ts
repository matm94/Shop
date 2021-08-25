import { Component, OnInit } from '@angular/core';
import { ApiDataService } from 'src/app/Shared/api-data.service';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent implements OnInit {
  orderDataFromApi;
  constructor(public dataFromAPi: ApiDataService, ) { }

  ngOnInit(): void {
  }
  GetOrderByLastNameFromApi(lastName: string): void
  {
    console.log(lastName);
    this.dataFromAPi.GetOrderByLastNameDataFromApi(lastName).subscribe(data =>
      {
        this.orderDataFromApi = data;
        console.log(this.orderDataFromApi);
      }, (err) =>
      {
        console.log('cannot get data from URL' + err);
      }
      );
  }

}
