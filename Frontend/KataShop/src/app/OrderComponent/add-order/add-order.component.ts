import { OrderServiceService } from './../../Shared/order-service.service';
import { ApiDataService } from 'src/app/Shared/api-data.service';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-add-order',
  templateUrl: './add-order.component.html',
  styleUrls: ['./add-order.component.css']
})
export class AddOrderComponent implements OnInit {

  addOrderForm: FormGroup = new FormGroup({});
  constructor(private formBuilder: FormBuilder, private apiData: ApiDataService) { }

  ngOnInit(): void {

    this.addOrderForm = this.formBuilder.group(
      {
        firstName: [''] ,
        lastName: [''] ,
        phoneNumber: [''] ,
        email: [''] ,
        orderStatus: [''] ,
        shipmentStatus: [''] ,
      });
  }

  /*addOrder(): void
  {
    this.orderService.addOrder().subscribe();
    console.log('nowe zamowienie');
  }*/

  /*onSubmit(): void
  {
    console.warn(this.addOrderForm.value);
  } */
  public onSubmit(): void
  {
    this.apiData.CreateOrder(this.addOrderForm.value).subscribe( data =>
      {
        console.log('Order created');
      }, (err) =>
      {
        console.log(err);
      });
  }
}
