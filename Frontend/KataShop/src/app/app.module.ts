import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { OrderComponent } from './OrderComponent/order/order.component';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { NavBarComponentComponent } from './nav-bar-component/nav-bar-component.component';
import { AllOrdersComponent } from './OrderComponent/all-orders/all-orders.component';
import { AddOrderComponent } from './OrderComponent/add-order/add-order.component';
import { DeleteOrderComponent } from './OrderComponent/delete-order/delete-order.component';
import { EditOrderComponent } from './OrderComponent/edit-order/edit-order.component';
import { ViewOrderComponent } from './OrderComponent/view-order/view-order.component';
import { SearchComponent } from './OrderComponent/search/search.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { FooterComponentComponent } from './footer-component/footer-component.component';


@NgModule({
  declarations: [
    AppComponent,
    OrderComponent,
    NavBarComponentComponent,
    AllOrdersComponent,
    AddOrderComponent,
    DeleteOrderComponent,
    EditOrderComponent,
    ViewOrderComponent,
    SearchComponent,
    FooterComponentComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    NgbModule,
    ReactiveFormsModule
  ],
  providers: [HttpClientModule],
  bootstrap: [AppComponent]
})
export class AppModule { }
