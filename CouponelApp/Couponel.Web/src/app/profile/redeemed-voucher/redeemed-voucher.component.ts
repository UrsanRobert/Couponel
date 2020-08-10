import { Component, OnInit } from '@angular/core';
import {RedeemedVoucherModel} from '../models/redeemed-voucher/redeemed-voucher.model';
import {RedeemedVoucherService} from '../../voucher/services/redeemed-voucher.service';
import {Router} from '@angular/router';
import {VoucherImageProvider} from '../../voucher/services/voucher-image-provider';

@Component({
  selector: 'app-redeemed-voucher',
  templateUrl: './redeemed-voucher.component.html',
  styleUrls: ['./redeemed-voucher.component.scss']
})
export class RedeemedVoucherComponent implements OnInit {
  redeemedVoucherList: RedeemedVoucherModel[];
constructor(
  private router: Router,
  private service: RedeemedVoucherService,
  private imageProvider: VoucherImageProvider) { }

  ngOnInit(): void {
    this.service.getAll().subscribe((data: RedeemedVoucherModel[]) => {
      console.log(data);
      this.redeemedVoucherList = data;
    });
  }

  getCategoryImage(category: any): string {
    return this.imageProvider.getCategoryImage(category);
  }

  goToVoucher(id: string): void {
    this.router.navigate([`/redeemed-vouchers/details/${id}`]);
  }
}