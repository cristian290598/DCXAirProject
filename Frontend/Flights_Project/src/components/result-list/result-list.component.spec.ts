import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ResultsListComponent } from './result-list.component';

describe('ResultListComponent', () => {
  let component: ResultsListComponent;
  let fixture: ComponentFixture<ResultsListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ResultsListComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ResultsListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
