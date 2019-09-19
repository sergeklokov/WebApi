import { PaymentDetailService } from './../../shared/payment-detail.service';
import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-payment-detail',
  templateUrl: './payment-detail.component.html',
  styles: []
})
export class PaymentDetailComponent implements OnInit {

  constructor(private service: PaymentDetailService) { }

  ngOnInit() { 
    this.resetForm();
   }

  resetForm(form?:NgForm){
    if(form != null)
      form.reset();

    this.service.formData = {
      PMId: 0,
      CardOwnerName:'',
      CardNumber: '',
      ExpirationDate:'',
      CVV:'',
    }
  }

  onSubmit(form:NgForm){
    
    this.service.postPaymentDetail(form.value).subscribe(
      res=>{
        this.resetForm(form);
      },
      err=>{
        console.log(err);
      }
    )
  }

}
