import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CratePatientsComponent } from './crate-patients.component';

describe('CratePatientsComponent', () => {
  let component: CratePatientsComponent;
  let fixture: ComponentFixture<CratePatientsComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [CratePatientsComponent]
    });
    fixture = TestBed.createComponent(CratePatientsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
