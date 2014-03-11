function CalculatorViewModel() {
    self = this;
    this.divideFirstNumber = ko.observable("");
    this.divideSecondNumber = ko.observable("");
    this.divideAnswer = ko.observable("=");
    this.divide = function () {
        self.divideAnswer((self.divideFirstNumber() / self.divideSecondNumber()).toString());
        self.divideFirstNumber("");
        self.divideSecondNumber("");
    }
}