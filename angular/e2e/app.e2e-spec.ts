import { AzSMTemplatePage } from './app.po';

describe('AzSM App', function() {
  let page: AzSMTemplatePage;

  beforeEach(() => {
    page = new AzSMTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
