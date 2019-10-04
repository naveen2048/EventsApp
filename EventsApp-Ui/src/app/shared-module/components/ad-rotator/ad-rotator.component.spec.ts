import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AdRotatorComponent } from './ad-rotator.component';

describe('AdRotatorComponent', () => {
  let component: AdRotatorComponent;
  let fixture: ComponentFixture<AdRotatorComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AdRotatorComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AdRotatorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
