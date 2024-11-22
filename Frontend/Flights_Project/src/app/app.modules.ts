import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { appRoutes } from './app.routes'; 
import { SearchFormModule } from '../components/search-form/search-form.module';  
import { ResultsListModule } from '../components/result-list/results-list.module';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input'; 
import { MatSelectModule } from '@angular/material/select';
import { MatOptionModule } from '@angular/material/core';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
  ],
  imports: [
    FormsModule,
    BrowserModule,
    BrowserAnimationsModule,
    HttpClientModule,
    MatFormFieldModule, 
    MatInputModule,     
    MatSelectModule,
    MatOptionModule,    
    RouterModule.forRoot(appRoutes),
    SearchFormModule,  
    ResultsListModule, 
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
