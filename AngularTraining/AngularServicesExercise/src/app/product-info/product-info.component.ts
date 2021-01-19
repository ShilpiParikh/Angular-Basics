import { Component, OnInit } from '@angular/core';
import { InfoServiceService } from '../info-service.service';
@Component({
  selector: 'app-product-info',
  templateUrl: './product-info.component.html',
  styleUrls: ['./product-info.component.css']
})
export class ProductInfoComponent implements OnInit {

  products: any = [];
  msg!: string;
  constructor(private service: InfoServiceService) { }

  ngOnInit(): void {
    this.service.getProduct()
      .subscribe(response => {
        this.products = response;
        console.log(response);
      });
  }

  deleteData(productName: string,productCode: string,branchName: string,branchCode: string,shippingAddress: string){​​

    console.log("Deleting Product");

    this.msg= 'Product deleted is :\n'+'Product Name: ' + productName +

                    '\nProduct Code: ' +productCode +

                    '\nBranch Name: ' + branchName +

                    '\nBranch Code: ' +branchCode +

                    '\nShipping Address: ' +shippingAddress;

    console.log(this.msg);

}​​
}




