import { SearchComponent } from './OrderComponent/search/search.component';
import { ViewOrderComponent } from './OrderComponent/view-order/view-order.component';
import { AddOrderComponent } from './OrderComponent/add-order/add-order.component';
import { EditOrderComponent } from './OrderComponent/edit-order/edit-order.component';
import { DeleteOrderComponent } from './OrderComponent/delete-order/delete-order.component';
import { AllOrdersComponent } from './OrderComponent/all-orders/all-orders.component';
import { NgModule, Component } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';


const routes: Routes = [
  {
     path: 'order',
      children:
      [
        {
          path: 'add', component: AddOrderComponent
        },
        {
          path: 'all', component: AllOrdersComponent
        },
        {
          path: 'delete/:id', component: DeleteOrderComponent
        },
        {
          path: 'edit/:id', component: EditOrderComponent
        },
        {
          path: 'search', component: SearchComponent
        },
        {
          path: 'view/:id', component: ViewOrderComponent
        },

      ]
  },

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
