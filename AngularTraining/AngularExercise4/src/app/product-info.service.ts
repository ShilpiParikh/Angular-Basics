import { Injectable } from '@angular/core';
import { ProductInfoClass } from './Product-Info-Class';

@Injectable({
  providedIn: 'root'
})
export class ProductInfoService implements ProductInfoClass{

  constructor(private productInfoClass: ProductInfoClass) { }
  ImagePath!: string;
  ProductName!: string;
  ProductCode!: number;
  BranchName!: string;
  BranchCode!: number;
  ShippingAddress!: string;

  ProductData: ProductInfoClass[]= [{
    ImagePath: './assets/images/mobile.jpg',
    ProductName: 'Mobile',
    ProductCode: 1,
    BranchName: 'area1',
    BranchCode: 1,
    ShippingAddress: 'add1'
  },
  {
    ImagePath: './assets/images/laptop.jpg',
    ProductName: 'Laptop',
    ProductCode: 2,
    BranchName: 'area2',
    BranchCode: 2,
    ShippingAddress: 'add2'
  },
  {
    ImagePath:'./assets/images/mouse.jpg',
    ProductName: 'Mouse',
    ProductCode: 3,
    BranchName: 'area3',
    BranchCode: 3,
    ShippingAddress: 'add3'
  },
  {
    ImagePath:'./assets/images/tablet.jpg',
    ProductName: 'Tablet',
    ProductCode: 4,
    BranchName: 'area3',
    BranchCode: 4,
    ShippingAddress: 'add4'
  },
] 
}
