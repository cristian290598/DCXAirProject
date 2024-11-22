import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ResultsListComponent } from './result-list.component';  

@NgModule({
  declarations: [ResultsListComponent],
  imports: [
    CommonModule,  
  ],
  exports: [ResultsListComponent],  
})
export class ResultsListModule {}