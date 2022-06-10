import { TestBed } from '@angular/core/testing';

import { CastSpellService } from './cast-spell.service';

describe('CastSpellService', () => {
  let service: CastSpellService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CastSpellService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
