"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var testing_1 = require("@angular/core/testing");
var convert_component_1 = require("./convert.component");
describe('ConvertComponent', function () {
    var fixture;
    beforeEach(testing_1.async(function () {
        testing_1.TestBed.configureTestingModule({
            declarations: [convert_component_1.ConvertComponent]
        })
            .compileComponents();
    }));
    beforeEach(function () {
        fixture = testing_1.TestBed.createComponent(convert_component_1.ConvertComponent);
        fixture.detectChanges();
    });
    it('should display a title', testing_1.async(function () {
        var titleText = fixture.nativeElement.querySelector('h1').textContent;
        expect(titleText).toEqual('Counter');
    }));
    it('should start with count 0, then increments by 1 when clicked', testing_1.async(function () {
        var countElement = fixture.nativeElement.querySelector('strong');
        expect(countElement.textContent).toEqual('0');
        var incrementButton = fixture.nativeElement.querySelector('button');
        incrementButton.click();
        fixture.detectChanges();
        expect(countElement.textContent).toEqual('1');
    }));
});
//# sourceMappingURL=convert.component.spec.js.map