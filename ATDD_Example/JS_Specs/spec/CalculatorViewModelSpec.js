describe("CalculatorViewModel specification", function() {

    describe("CalculatorViewModel when created", function() {
        var sut;

        beforeEach(function() {
            sut = new CalculatorViewModel();
        });

        it("should have expected first divide number", function() {
            expect(sut.divideFirstNumber()).toEqual("");
        });

        it("should have expected second divide number", function() {
            expect(sut.divideSecondNumber()).toEqual("");
        });

        it("should have expected divide answer", function() {
            expect(sut.divideAnswer()).toEqual("=");
        });

    });
    
    describe("CalculatorViewModel when divide 35 by 7", function() {
        var sut;

        beforeEach(function() {
            sut = new CalculatorViewModel();
            sut.divideFirstNumber("35");
            sut.divideSecondNumber("7");
            sut.divide();
        });

        it("should have expected first divide number", function() {
            expect(sut.divideFirstNumber()).toEqual("");
        });

        it("should have expected second divide number", function() {
            expect(sut.divideSecondNumber()).toEqual("");
        });

        it("should have expected divide answer", function() {
            expect(sut.divideAnswer()).toEqual("5");
        });

    });
});