import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Order } from '../Models/Order';

@Injectable({
  providedIn: 'root'
})
export class ApiDataService {

  constructor(private client: HttpClient) { }

   GetOrderByLastNameDataFromApi(): Observable<Order>
   {
      return this.client.get<Order>('https://localhost:44354/api/Order/GetOrderByLastName?lastName=Rivia');
   }
   GetAllOrdersDataFromApi(): Observable<Array<Order>>
   {
     return this.client.get<Array<Order>>('https://localhost:44354/GetAllOrders');
   }
}

