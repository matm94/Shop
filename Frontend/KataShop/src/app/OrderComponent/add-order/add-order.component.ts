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

  constructor(private formbuilder: FormBuilder, private apiData: ApiDataService) { }

  ngOnInit(): void {

    this.addOrderForm = this.formbuilder.group(
      {
        firstName: new FormControl(''),
        lastName: new FormControl(''),
        phoneNumber: new FormControl(''),
        email: new FormControl(''),
        orderStatus: new FormControl(''),
        shipmentStatus: new FormControl(''),
      }
    );
    this.addOrder();
  }

  public addOrder(): void
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
