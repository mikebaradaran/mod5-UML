const { expect } = require('chai');
const sinon = require('sinon');
const { Position, ICalcMethod, IncomeCalculator } = require('./IncomeCalculator');

describe('IncomeCalculator.calc()', function () {

    let calc;
    let calcMethod;

    beforeEach(() => {
        calcMethod = sinon.stub(new ICalcMethod());
        calc = new IncomeCalculator();
    });

    it('calculates income using ICalcMethod object', function () {
        // Mock the ICalcMethod to return specific incomes
        calcMethod.calc.withArgs(Position.BOSS).returns(70000);
        calcMethod.calc.withArgs(Position.PROGRAMMER).returns(50000);

        // Configure the ICalcMethod object
        calc.setCalcMethod(calcMethod);

        calc.setPosition(Position.BOSS);
        const income1 = calc.calc();
        expect(income1).to.equal(70000);

        calc.setPosition(Position.BOSS);
        const income2 = calc.calc();
        expect(income2).to.equal(70000);

        calc.setPosition(Position.PROGRAMMER);
        const income3 = calc.calc();
        expect(income3).to.equal(50000);

        // Verify that ICalcMethod.calc was called expected number of times
        sinon.assert.callCount(calcMethod.calc, 3);
    });

    it('throws exception if called without calc method set', function () {
        calc.setPosition(Position.BOSS);

        expect(() => calc.calc()).to.throw('Calc method not yet maintained');
        sinon.assert.notCalled(calcMethod.calc);
    });

    it('throws exception if called without position set', function () {
        calc.setCalcMethod(calcMethod);

        expect(() => calc.calc()).to.throw('Position not yet maintained');
        sinon.assert.notCalled(calcMethod.calc);
    });

    it('throws exception if ICalcMethod.calc throws exception', function () {
        calcMethod.calc.withArgs(Position.SURFER).throws(new Error("Don't know this guy!"));

        calc.setCalcMethod(calcMethod);
        calc.setPosition(Position.SURFER);

        expect(() => calc.calc()).to.throw("Don't know this guy!");
    });
});
