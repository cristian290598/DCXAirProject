import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatRadioModule } from '@angular/material/radio';
import { MatSelectModule } from '@angular/material/select';
import { MatOptionModule } from '@angular/material/core';  
import { NgModule } from '@angular/core';
import { SearchFormComponent } from './search-form.component';
import { ResultsListComponent } from '../result-list/result-list.component';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

@NgModule({
  declarations: [
    SearchFormComponent,
    ResultsListComponent,
  ],
  imports: [
    CommonModule,
    FormsModule,    
    ReactiveFormsModule, 
    MatFormFieldModule,
    MatInputModule,
    MatRadioModule,
    MatSelectModule,
    MatOptionModule,   
    BrowserAnimationsModule,  
  ],
})
export class SearchFormModule { }