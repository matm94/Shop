import { NewOrder } from './../Models/NewOrder';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { FormBuilder, FormControl } from '@angular/forms';
import { Observable } from 'rxjs';
import { Order } from '../Models/Order';

@Injectable({
  providedIn: 'root'
})
export class OrderServiceService {

  constructor(private formBuilder: FormBuilder, private http: HttpClient) { }

  /* addOrderForm = this.formBuilder.group(
    {
      firstName: new FormControl('') ,
      lastName: new FormControl(''),
      phoneNumber: new FormControl(''),
      email: new FormControl(''),
      orderStatus: new FormControl(''),
      shipmentStatus: new FormControl(''),
    }
  );

  addOrder(): Observable<NewOrder>
  {
   const newOrder: NewOrder =
    {
      firstName: this.addOrderForm.value.firstName,
      lastName: this.addOrderForm.value.lastName,
      phoneNumber: this.addOrderForm.value.number,
      email: this.addOrderForm.value.email,
      orderStatus: this.addOrderForm.value.orderStatus,
      shipmentStatus: this.addOrderForm.value.shipmentStatus,
    };
    // tslint:disable-next-line:quotemark
    return this.http.post<NewOrder>("https://localhost:44354/api/Order", this.addOrderForm.value);
  }*/

}
