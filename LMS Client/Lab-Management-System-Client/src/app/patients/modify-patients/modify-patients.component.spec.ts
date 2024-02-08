import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ModifyPatientsComponent } from './modify-patients.component';

describe('ModifyPatientsComponent', () => {
  let component: ModifyPatientsComponent;
  let fixture: ComponentFixture<ModifyPatientsComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ModifyPatientsComponent]
    });
    fixture = TestBed.createComponent(ModifyPatientsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
