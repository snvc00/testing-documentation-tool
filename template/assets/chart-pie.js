// Set new default font family and font color to mimic Bootstrap's default styling
Chart.defaults.global.defaultFontFamily = '-apple-system,system-ui,BlinkMacSystemFont,"Segoe UI",Roboto,"Helvetica Neue",Arial,sans-serif';
Chart.defaults.global.defaultFontColor = '#292b2c';

dataFunctionalNewFeatures = [0, 2];
dataFunctionalEnhancements = [1, 0];
dataNonFunctionalNewFeatures = [0, 1];
dataNonFunctionalEnhancements = [1, 0];

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
document.getElementById("pieChart1").innerHTML = "Total Tests: " + (dataFunctionalEnhancements[0]+dataFunctionalEnhancements[1]) + ", Passed: " + dataFunctionalEnhancements[1] + ", Failed: " + dataFunctionalEnhancements[0];
document.getElementById("pieChart2").innerHTML = "Total Tests: " + (dataNonFunctionalNewFeatures[0]+dataNonFunctionalNewFeatures[1]) + ", Passed: " + dataNonFunctionalNewFeatures[1] + ", Failed: " + dataNonFunctionalNewFeatures[0];
document.getElementById("pieChart3").innerHTML = "Total Tests: " + (dataNonFunctionalEnhancements[0]+dataNonFunctionalEnhancements[1]) + ", Passed: " + dataNonFunctionalEnhancements[1] + ", Failed: " + dataNonFunctionalEnhancements[0];

// Pie Chart Functional New Features
var ctx = document.getElementById("myPieChart");
var myPieChart = new Chart(ctx, {
  type: 'pie',
  options: customOptions,
  data: {
    labels: ["Failed", "Successful"],
    datasets: [{
      data: dataFunctionalNewFeatures,
      backgroundColor: ["rgba(217, 65, 65, 1)", "rgba(65, 217, 65, 1)"],
    }],
  }
});

// Pie Chart Funtional Enhancement
var ctx = document.getElementById("functionalEnhancementsResults");
var myPieChart1 = new Chart(ctx, {
  type: 'pie',
  options: customOptions,
  data: {
    labels: ["Failed", "Successful"],
    datasets: [{
      data: dataFunctionalEnhancements,
      backgroundColor: ["rgba(217, 65, 65, 1)", "rgba(65, 217, 65, 1)"],
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
      backgroundColor: ["rgba(217, 65, 65, 1)", "rgba(65, 217, 65, 1)"],
    }],
  },
});

// Pie Chart Non Functional Enhancement
var ctx = document.getElementById("nonFunctionalEnhancementsResults");
var myPieChart3 = new Chart(ctx, {
  type: 'pie',
  options: customOptions,
  data: {
    labels: ["Failed", "Successful"],
    datasets: [{
      data: dataNonFunctionalEnhancements,
      backgroundColor: ["rgba(217, 65, 65, 1)", "rgba(65, 217, 65, 1)"],
    }],
  },
});
