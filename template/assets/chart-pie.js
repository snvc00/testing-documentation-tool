// Set new default font family and font color to mimic Bootstrap's default styling
Chart.defaults.global.defaultFontFamily = '-apple-system,system-ui,BlinkMacSystemFont,"Segoe UI",Roboto,"Helvetica Neue",Arial,sans-serif';
Chart.defaults.global.defaultFontColor = '#292b2c';

/*dataset0*/dataFunctionalNewFeatures = [1, 2];
/*dataset1*/dataFunctionalEnhacenments = [1, 2];
/*dataset2*/dataNonFunctionalNewFeatures = [2, 2];
/*dataset3*/dataNonFunctionalEnhacenments = [3, 1];

// Pie Chart Functional New Features
var ctx = document.getElementById("myPieChart");
var myPieChart = new Chart(ctx, {
  type: 'pie',
  options: {
    legend:{
      display: false
    },
    plugins: {
      datalabels: {
          formatter: (value) => {
              let sum = 0;
              let dataArr = dataFunctionalNewFeatures;
              dataArr.map(data => {
                  sum += data;
              });
              let percentage = (value*100 / sum).toFixed(2)+"%";
              return percentage;
          },
          color: '#fff',
      }
    }
  },
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
  options: {
    legend:{
      display: false
    }
  },
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
  options: {
    legend:{
      display: false
    }
  },
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
  options: {
    legend:{
      display: false
    }
  },
  data: {
    labels: ["Failed", "Successful"],
    datasets: [{
      data: dataNonFunctionalEnhacenments,
      backgroundColor: ["rgba(255, 0, 0, 0.7)", "rgba(0, 255, 0, 0.7)"],
    }],
  },
});