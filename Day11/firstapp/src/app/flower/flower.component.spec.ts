import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FlowerComponent } from './flower.component';

describe('FlowerComponent', () => {
  let component: FlowerComponent;
  let fixture: ComponentFixture<FlowerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FlowerComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FlowerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
