import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PostPatientsComponent } from './post-patients.component';

describe('PostPatientsComponent', () => {
  let component: PostPatientsComponent;
  let fixture: ComponentFixture<PostPatientsComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [PostPatientsComponent]
    });
    fixture = TestBed.createComponent(PostPatientsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
