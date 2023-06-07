import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-add-product',
  templateUrl: './add-product.component.html',
})
export class AddProductComponent {
  newProduct: any = {};
  baseUrl: string = '';
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) { }

  addProduct(): void {
    this.http.post(this.baseUrl + 'produkt', this.newProduct).subscribe(() => {
      alert('Produkt został dodany!');
      this.newProduct = {};
    });
  }
}
