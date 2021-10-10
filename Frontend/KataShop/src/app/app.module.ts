import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { OrderComponent } from './OrderComponent/order/order.component';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { NavBarComponentComponent } from './nav-bar-component/nav-bar-component.component';
import { AllOrdersComponent } from './OrderComponent/order/all-orders/all-orders.component';
import { AddOrderComponent } from './OrderComponent/order/add-order/add-order.component';
import { DeleteOrderComponent } from './OrderComponent/order/delete-order/delete-order.component';
import { EditOrderComponent } from './OrderComponent/order/edit-order/edit-order.component';
import { ViewOrderComponent } from './OrderComponent/order/view-order/view-order.component';
import { SearchComponent } from './OrderComponent/order/search/search.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { FooterComponentComponent } from './footer-component/footer-component.component';
import { UserComponent} from './user/user.component';
import { LoginComponent} from './user/login/login.component';
import { RegistrationComponent } from './user/registration/registration.component';



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
    FooterComponentComponent,
    UserComponent,
    LoginComponent,
    RegistrationComponent
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
