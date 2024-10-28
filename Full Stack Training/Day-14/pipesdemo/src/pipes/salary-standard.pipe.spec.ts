import { SalaryStandardPipe } from './salary-standard.pipe';

describe('SalaryStandardPipe', () => {
  it('create an instance', () => {
    const pipe = new SalaryStandardPipe();
    expect(pipe).toBeTruthy();
  });
});
