// Set new default font family and font color to mimic Bootstrap's default styling
Chart.defaults.global.defaultFontFamily = '-apple-system,system-ui,BlinkMacSystemFont,"Segoe UI",Roboto,"Helvetica Neue",Arial,sans-serif';
Chart.defaults.global.defaultFontColor = '#292b2c';

dataFunctionalNewFeatures = [32, 13];
dataFunctionalEnhacenments = [4, 12];
dataNonFunctionalNewFeatures = [12, 34];
dataNonFunctionalEnhacenments = [10, 10];

var customOptions = {
  legend:{
    display: false
  },
  tooltips: {
    callbacks: {
      label: function(tooltipItem, data) {
        var dataset = data.datasets[tooltipItem.datasetIndex];
        var total = dataset.data.reduce(function(previousValue, currentValue, currentIndex, array) {
          return previousValue + currentValue;
        });
        var currentValue = dataset.data[tooltipItem.index];
        var percentage = Math.floor(((currentValue/total) * 100)+0.5);
  
        return percentage + "%";
      }
    }
  } 
};

document.getElementById("pieChart0").innerHTML = "Total Tests: " + (dataFunctionalNewFeatures[0]+dataFunctionalNewFeatures[1]) + ", Passed: " + dataFunctionalNewFeatures[1] + ", Failed: " + dataFunctionalNewFeatures[0];
document.getElementById("pieChart1").innerHTML = "Total Tests: " + (dataFunctionalEnhacenments[0]+dataFunctionalEnhacenments[1]) + ", Passed: " + dataFunctionalEnhacenments[1] + ", Failed: " + dataFunctionalEnhacenments[0];
document.getElementById("pieChart2").innerHTML = "Total Tests: " + (dataNonFunctionalNewFeatures[0]+dataNonFunctionalNewFeatures[1]) + ", Passed: " + dataNonFunctionalNewFeatures[1] + ", Failed: " + dataNonFunctionalNewFeatures[0];
document.getElementById("pieChart3").innerHTML = "Total Tests: " + (dataNonFunctionalEnhacenments[0]+dataNonFunctionalEnhacenments[1]) + ", Passed: " + dataNonFunctionalEnhacenments[1] + ", Failed: " + dataNonFunctionalEnhacenments[0];

// Pie Chart Functional New Features
var ctx = document.getElementById("myPieChart");
var myPieChart = new Chart(ctx, {
  type: 'pie',
  options: customOptions,
  data: {
    labels: ["Failed", "Successful"],
    datasets: [{
      data: dataFunctionalNewFeatures,
      backgroundColor: ["rgba(255, 0, 0, 0.7)", "rgba(0, 255, 0, 0.7)"],
    }],
  }
});

// Pie Chart Funtional Enhacenment
var ctx = document.getElementById("functionalEnhacenmentsResults");
var myPieChart1 = new Chart(ctx, {
  type: 'pie',
  options: customOptions,
  data: {
    labels: ["Failed", "Successful"],
    datasets: [{
      data: dataFunctionalEnhacenments,
      backgroundColor: ["rgba(255, 0, 0, 0.7)", "rgba(0, 255, 0, 0.7)"],
    }],
  },
});

// Pie Chart Non Functional New Features
var ctx = document.getElementById("nonFunctionalNewFeaturesResults");
var myPieChart2 = new Chart(ctx, {
  type: 'pie',
  options: customOptions,
  data: {
    labels: ["Failed", "Successful"],
    datasets: [{
      data: dataNonFunctionalNewFeatures,
      backgroundColor: ["rgba(255, 0, 0, 0.7)", "rgba(0, 255, 0, 0.7)"],
    }],
  },
});

// Pie Chart Non Functional Enhacenment
var ctx = document.getElementById("nonFunctionalEnhacenmentsResults");
var myPieChart3 = new Chart(ctx, {
  type: 'pie',
  options: customOptions,
  data: {
    labels: ["Failed", "Successful"],
    datasets: [{
      data: dataNonFunctionalEnhacenments,
      backgroundColor: ["rgba(255, 0, 0, 0.7)", "rgba(0, 255, 0, 0.7)"],
    }],
  },
});
