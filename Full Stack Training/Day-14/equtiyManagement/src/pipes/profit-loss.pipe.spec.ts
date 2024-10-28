import { ProfitLossPipe } from './profit-loss.pipe';

describe('ProfitLossPipe', () => {
  it('create an instance', () => {
    const pipe = new ProfitLossPipe();
    expect(pipe).toBeTruthy();
  });
});
