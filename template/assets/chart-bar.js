// Set new default font family and font color to mimic Bootstrap's default styling
Chart.defaults.global.defaultFontFamily = '-apple-system,system-ui,BlinkMacSystemFont,"Segoe UI",Roboto,"Helvetica Neue",Arial,sans-serif';
Chart.defaults.global.defaultFontColor = '#292b2c';

dataFunctionalNewFeaturesBar = [0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0];
dataFunctionalEnhacenmentBar = [0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0];
dataNonFunctionalNewFeaturesBar = [0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0];
dataNonFunctionalEnhacenmentBar = [0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0];

// Bar Chart Functional New Features
var ctx = document.getElementById("myBarChart");
var myLineChart = new Chart(ctx, {
  type: 'bar',
  data: {
    labels: ["Login", "Home", "Keyword", "Test Cases", "Test Suites", "Imported Scripts", "Collections", "Parameters", "Templates", "Profiles", "Commands", "Robot Framework", "Products", "Libraries", "Phases", "Users", "Information Panel"],
    datasets: [{
      label: "Number of Test Cases",
      backgroundColor: "rgba(2,117,216,0.7)",
      borderColor: "rgba(2,117,216,1)",
      data: dataFunctionalNewFeaturesBar,
    }],
  },
  options: {
    scales: {
      xAxes: [{
        gridLines: {
          display: false
        },
      }],
      yAxes: [{
        ticks: {
          min: 0,
          max: 10,
          maxTicksLimit: 5
        },
        gridLines: {
          display: true
        }
      }],
    },
    legend: {
      display: false
    }
  }
});

// Bar Chart Functional Enhacenments
var ctx = document.getElementById("funtionalEnhacenmentChart");
var myLineChart1 = new Chart(ctx, {
  type: 'bar',
  data: {
    labels: ["Login", "Home", "Keyword", "Test Cases", "Test Suites", "Imported Scripts", "Collections", "Parameters", "Templates", "Profiles", "Commands", "Robot Framework", "Products", "Libraries", "Phases", "Users", "Information Panel"],
    datasets: [{
      label: "Number of Test Cases",
      backgroundColor: "rgba(2,117,216,0.7)",
      borderColor: "rgba(2,117,216,1)",
      data: dataFunctionalEnhacenmentBar,
    }],
  },
  options: {
    scales: {
      xAxes: [{
        gridLines: {
          display: false
        },
      }],
      yAxes: [{
        ticks: {
          min: 0,
          max: 10,
          maxTicksLimit: 5
        },
        gridLines: {
          display: true
        }
      }],
    },
    legend: {
      display: false
    }
  }
});

// Bar Chart Non Functional New Features
var ctx = document.getElementById("nonFunctionalNewFeaturesChart");
var myLineChart2 = new Chart(ctx, {
  type: 'bar',
  data: {
    labels: ["Login", "Home", "Keyword", "Test Cases", "Test Suites", "Imported Scripts", "Collections", "Parameters", "Templates", "Profiles", "Commands", "Robot Framework", "Products", "Libraries", "Phases", "Users", "Information Panel"],
    datasets: [{
      label: "Number of Test Cases",
      backgroundColor: "rgba(216,117,2,0.7)",
      borderColor: "rgba(2,117,216,1)",
      data: dataNonFunctionalNewFeaturesBar,
    }],
  },
  options: {
    scales: {
      xAxes: [{
        gridLines: {
          display: false
        },
      }],
      yAxes: [{
        ticks: {
          min: 0,
          max: 10,
          maxTicksLimit: 5
        },
        gridLines: {
          display: true
        }
      }],
    },
    legend: {
      display: false
    }
  }
});

// Bar Chart Non Functional Enhacenment
var ctx = document.getElementById("nonFunctionalEnhacenmentChart");
var myLineChart3 = new Chart(ctx, {
  type: 'bar',
  data: {
    labels: ["Login", "Home", "Keyword", "Test Cases", "Test Suites", "Imported Scripts", "Collections", "Parameters", "Templates", "Profiles", "Commands", "Robot Framework", "Products", "Libraries", "Phases", "Users", "Information Panel"],
    datasets: [{
      label: "Number of Test Cases",
      backgroundColor: "rgba(216,117,2,0.7)",
      borderColor: "rgba(2,117,216,1)",
      data: dataNonFunctionalEnhacenmentBar,
    }],
  },
  options: {
    scales: {
      xAxes: [{
        gridLines: {
          display: false
        },
      }],
      yAxes: [{
        ticks: {
          min: 0,
          max: 10,
          maxTicksLimit: 5
        },
        gridLines: {
          display: true
        }
      }],
    },
    legend: {
      display: false
    }
  }
});
