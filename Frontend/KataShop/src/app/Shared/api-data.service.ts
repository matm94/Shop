import { OrderQuery } from './../Models/OrderQuery';
import { APIOrderPageResult } from './../Models/APIOrderPageResult';
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
   GetAllOrdersDataFromApi(): Observable<APIOrderPageResult>
   {
     // tslint:disable-next-line:quotemark
     return this.client.get<APIOrderPageResult>
            // tslint:disable-next-line:quotemark
            ("https://localhost:44354/GetAllOrders?PageNumber=1&PageSize=10");
   }
   GetCompleteOrderById(id: string): Observable<CompleteOrder>
   {
     // tslint:disable-next-line:quotemark
     return this.client.get<CompleteOrder>("https://localhost:44354/api/Order/GetCompleteOreder?id=" + id);
   }

   CreateOrder(order: Order): Observable<Order>
   {
     // tslint:disable-next-line:quotemark
     return this.client.post<Order>("https://localhost:44354/api/Order/", order);
   }
}

