import { Component, OnInit } from '@angular/core';
import { ProductInfoClass } from '../Product-Info-Class';
import { ProductInfoService } from '../product-info.service';

@Component({
  selector: 'app-product-info',
  templateUrl: './product-info.component.html',
  styleUrls: ['./product-info.component.css']
})
export class ProductInfoComponent implements OnInit {
  ProductData: ProductInfoClass[] = [];
  messageAlert: string = '';
  constructor(private productInfoService: ProductInfoService) { }

  ngOnInit(): void {
    this.ProductData = this.productInfoService.ProductData;
  }

  displayData(data:ProductInfoClass){
    
    this.messageAlert = 'Product Name: ' + data.ProductName +

                        '\nProduct Code: ' + data.ProductCode +

                        '\nBranch Name: ' + data.BranchName +

                        '\nBranch Code: ' + data.BranchCode +

                       '\nShipping Address: ' + data.ShippingAddress;
    alert(this.messageAlert);

  }

}
