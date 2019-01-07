import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BookCategoryGetallComponent } from './book-category-getall.component';

describe('BookCategoryGetallComponent', () => {
  let component: BookCategoryGetallComponent;
  let fixture: ComponentFixture<BookCategoryGetallComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BookCategoryGetallComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BookCategoryGetallComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
