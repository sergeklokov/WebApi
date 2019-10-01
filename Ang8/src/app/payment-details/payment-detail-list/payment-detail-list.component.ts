import { PaymentDetail } from './../../shared/payment-detail.model';
import { PaymentDetailService } from './../../shared/payment-detail.service';
import { Component, OnInit } from '@angular/core';
// add toaster control

@Component({
  selector: 'app-payment-detail-list',
  templateUrl: './payment-detail-list.component.html',
  styles: []
})
export class PaymentDetailListComponent implements OnInit {

  constructor(private service: PaymentDetailService) { }

  ngOnInit() {
    this.service.refreshList();
  }

  populateForm(pd: PaymentDetail){
    this.service.formData = Object.assign({}, pd);
    //alert(this.service.formData.CardOwnerName);
  }

  onDelete(PMId){
    if(confirm('Are you sure to delete this record?')){
      this.service.deletePaymentDetail(PMId)
      .subscribe(res=> {
        debugger;
        this.service.refreshList();
        //toaster
      },
      err => {debugger;
      console.log(err);
      })
    }
  }
}
