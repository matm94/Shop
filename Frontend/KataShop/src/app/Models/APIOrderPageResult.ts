import { Order } from './Order';
export class APIOrderPageResult
{
  items: Order[];
  totalPages: number;
  itemFrom: number;
  itemTo: number;
  totalItemsCount: number;

}
