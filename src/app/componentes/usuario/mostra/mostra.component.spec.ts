import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MostraComponent } from './mostra.component';

describe('MostraComponent', () => {
  let component: MostraComponent;
  let fixture: ComponentFixture<MostraComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MostraComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MostraComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
