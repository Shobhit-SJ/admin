import { NgClass, NgFor, UpperCasePipe } from '@angular/common';
import { Component } from '@angular/core';
import { ProfitLossPipe } from '../../pipes/profit-loss.pipe';

@Component({
  selector: 'app-stock-info',
  standalone: true,
  imports: [NgFor,UpperCasePipe,ProfitLossPipe,NgClass],
  templateUrl: './stock-info.component.html',
  styleUrl: './stock-info.component.css'
})
export class StockInfoComponent {

  stockList=[
    {stockId: 101, stockName: "tata", stockSector: "Manufacturing", stockQty: 250, purchasePrice: 1800, currentPrice: 2100},
    {stockId: 102, stockName: "ADani", stockSector: "Construction", stockQty: 210, purchasePrice: 410, currentPrice: 400},
    {stockId: 103, stockName: "TcS", stockSector: "IT", stockQty: 150, purchasePrice: 2090, currentPrice: 3100},
    {stockId: 104, stockName: "TITan", stockSector: "Manufacturing", stockQty: 450, purchasePrice: 1200, currentPrice: 1101},
  ]
  

}
