import { AuthGuard } from './auth.guard';
import { OrderComponent } from './OrderComponent/order/order.component';
import { RegistrationComponent } from './user/registration/registration.component';
import { LoginComponent } from './user/login/login.component';
import { SearchComponent } from './OrderComponent/order/search/search.component';
import { ViewOrderComponent } from './OrderComponent/order/view-order/view-order.component';
import { AddOrderComponent } from './OrderComponent/order/add-order/add-order.component';
import { EditOrderComponent } from './OrderComponent/order/edit-order/edit-order.component';
import { DeleteOrderComponent } from './OrderComponent/order/delete-order/delete-order.component';
import { AllOrdersComponent } from './OrderComponent/order/all-orders/all-orders.component';
import { NgModule, Component } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';


const routes: Routes = [
  {
    path: '', redirectTo: 'user/registration', pathMatch: 'full'
  },
  {
    path: 'user',
      children:
      [
        {
          path: 'login', component: LoginComponent
        },
        {
          path: 'registration', component: RegistrationComponent
        }
      ]
  },
  {
     path: 'order', component: OrderComponent,
      children:
      [
        {
          path: 'add', component: AddOrderComponent, canActivate: [AuthGuard]
        },
        {
          path: 'all', component: AllOrdersComponent, canActivate: [AuthGuard]
        },
        {
          path: 'delete/:id', component: DeleteOrderComponent, canActivate: [AuthGuard]
        },
        {
          path: 'edit/:id', component: EditOrderComponent, canActivate: [AuthGuard]
        },
        {
          path: 'search', component: SearchComponent, canActivate: [AuthGuard]
        },
        {
          path: 'view/:id', component: ViewOrderComponent, canActivate: [AuthGuard]
        },

      ]
  },

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
