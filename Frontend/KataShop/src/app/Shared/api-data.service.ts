import { CompleteOrder } from './../Models/CompleteOrder';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Order } from '../Models/Order';

@Injectable({
  providedIn: 'root'
})
export class ApiDataService {

  constructor(private client: HttpClient) { }

   GetOrderByLastNameDataFromApi(lastName: string): Observable<Order>
   {
      // tslint:disable-next-line:quotemark
      return this.client.get<Order>("https://localhost:44354/api/Order/GetOrderByLastName?lastName=" + lastName);
   }
   GetOrderByIdDataFromApi(id: string): Observable<Order>
   {
     // tslint:disable-next-line:quotemark
     return this.client.get<Order>("https://localhost:44354/api/Order/GetOrderById?id=" + id);
   }
   GetAllOrdersDataFromApi(): Observable<Array<Order>>
   {
     // tslint:disable-next-line:quotemark
     return this.client.get<Array<Order>>("https://localhost:44354/GetAllOrders");
   }
   GetCompleteOrderById(id: string): Observable<CompleteOrder>
   {
     // tslint:disable-next-line:quotemark
     return this.client.get<CompleteOrder>("https://localhost:44354/api/Order/GetCompleteOreder?id=" + id);
   }
}

