import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BookCategoryDetailComponent } from './book-category-detail.component';

describe('BookCategoryDetailComponent', () => {
  let component: BookCategoryDetailComponent;
  let fixture: ComponentFixture<BookCategoryDetailComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BookCategoryDetailComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BookCategoryDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
