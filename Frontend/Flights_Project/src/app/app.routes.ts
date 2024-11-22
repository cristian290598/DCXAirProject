import { Routes } from '@angular/router';
import { SearchFormComponent } from '../components/search-form/search-form.component';
import { ResultsListComponent } from '../components/result-list/result-list.component';

export const appRoutes: Routes = [
    
  { path: '', component: SearchFormComponent }, 
  { path: 'results', component: ResultsListComponent }, 
];

